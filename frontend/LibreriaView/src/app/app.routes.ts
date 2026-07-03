import { Routes } from '@angular/router';
import { InicioComponent } from './components/inicio-component/inicio-component';
import { ProductosComponent } from './components/productos-component/productos-component';
import { ContactosComponent } from './components/contactos-component/contactos-component';

export const routes: Routes = [
    { path: '', component: InicioComponent, title: 'Inicio · Librería O-Mar ECP' },
  { path: 'productos', component: ProductosComponent, title: 'Productos · Librería O-Mar ECP' },
  { path: 'contacto', component: ContactosComponent, title: 'Contacto · Librería O-Mar ECP' },
  { path: '**', redirectTo: '' }
];
