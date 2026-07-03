import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { RouterLink } from '@angular/router';
import { LibroService } from '../../services/libro-service';
import { Libro } from '../../models/libro';
import { environment } from '../../../environments/environment.development';

@Component({
  selector: 'app-inicio-component',
  imports: [CommonModule, RouterLink],
  templateUrl: './inicio-component.html',
  styleUrl: './inicio-component.css',
})
export class InicioComponent {
   librosDestacados: Libro[] = [];
  cargando = true;
  error = false;

  constructor(private libroService: LibroService) {
    this.obtenerLibros();
  }

  obtenerLibros(): void {
    this.libroService.getLibros().subscribe({
      next: (libros) => {
        this.librosDestacados = libros.slice(0, 3);
        this.cargando = false;
      },
      error: () => {
        this.error = true;
        this.cargando = false;
      }
    });
  }

obtenerNombreArchivo(ruta: string): string {
  if (!ruta) return '';
  return ruta.substring(ruta.lastIndexOf('/') + 1);
}
}
