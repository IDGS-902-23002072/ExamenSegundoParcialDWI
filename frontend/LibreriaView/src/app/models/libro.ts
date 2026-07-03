import { Categoria } from "./categoria";


export interface Libro {
  idLibro: number;
  nombreLibro: string;
  descripcion: string;
  precio: number;
  imagURL: string;
  autor: string;
  categoriaId: number;
  categoria?: Categoria;
}
