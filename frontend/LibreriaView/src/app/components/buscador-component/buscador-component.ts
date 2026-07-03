import { CommonModule } from '@angular/common';
import { Component, input, output} from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Categoria } from '../../models/categoria';
import { Libro } from '../../models/libro';
import { LibroService } from '../../services/libro-service';
import { CategoriaService } from '../../services/categoria-service';

@Component({
  selector: 'app-buscador-component',
  imports: [CommonModule, FormsModule],
  templateUrl: './buscador-component.html',
  styleUrl: './buscador-component.css',
})
export class BuscadorComponent {
   todosLosLibros: Libro[] = [];
  librosFiltrados: Libro[] = [];
  categorias: Categoria[] = [];
  ruta :string = "/public"

  textoBusqueda = '';
  categoriaSeleccionada: number | null = null;

  cargando = true;
  error = false;

  constructor(
    private libroService: LibroService,
    private categoriaService: CategoriaService
  ) {
  }

  ngOnInit(): void {
           this.categoriaService.getCategorias().subscribe({
      next: (categorias) => {
        this.categorias = categorias;
      }
    });

    this.libroService.getLibros().subscribe({
      next: (libros) => {
        this.todosLosLibros = libros;
        this.librosFiltrados = libros;
        this.cargando = false;
      },
      error: (err) => {
  console.error('Error cargando libros:', err);
  this.error = true;
  this.cargando = false;
}
    });
  }

  filtrar(): void {
    const texto = this.textoBusqueda.trim().toLowerCase();

    this.librosFiltrados = this.todosLosLibros.filter((libro) => {
      const coincideNombre = libro.nombreLibro.toLowerCase().includes(texto);
      const coincideCategoria =
        this.categoriaSeleccionada === null || libro.categoriaId === this.categoriaSeleccionada;
      return coincideNombre && coincideCategoria;
    });
  }

  seleccionarCategoria(id: number | null): void {
    if (this.categoriaSeleccionada === id) {
      this.categoriaSeleccionada = null;
    } else {
      this.categoriaSeleccionada = id;
    }
    this.filtrar();
  }

obtenerNombreArchivo(ruta: string): string {
  if (!ruta) return '';
  return ruta.substring(ruta.lastIndexOf('/') + 1);
}
}
