import { Component } from '@angular/core';
import { RouterLink, RouterLinkActive } from '@angular/router';

@Component({
  selector: 'app-cabecera-component',
  imports: [RouterLink, RouterLinkActive],
  templateUrl: './cabecera-component.html',
  styleUrl: './cabecera-component.css',
})
export class CabeceraComponent {}
