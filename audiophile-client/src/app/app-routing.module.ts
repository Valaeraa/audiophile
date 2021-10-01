import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  {
    path: 'headphones',
    loadChildren: () =>
      import('./shop/headphones/headphones.module').then(
        (mod) => mod.HeadphonesModule
      ),
  },
  {
    path: 'speakers',
    loadChildren: () =>
      import('./shop/speakers/speakers.module').then(
        (mod) => mod.SpeakersModule
      ),
  },
  {
    path: 'earphones',
    loadChildren: () =>
      import('./shop/earphones/earphones.module').then(
        (mod) => mod.EarphonesModule
      ),
  },
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes, { scrollPositionRestoration: 'enabled' }),
  ],
  exports: [RouterModule],
})
export class AppRoutingModule {}
