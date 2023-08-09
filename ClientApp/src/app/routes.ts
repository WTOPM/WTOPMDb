import { Routes } from "@angular/router";
import { HomeComponent } from "./home/home.component";
import { RegisterComponent } from "./register/register.component";
import { MainComponent } from "./main/main.component";
import { AuthGuard } from "./_guards/auth.guard";
import { LogoutGuard } from "./_guards/logout.guard";

export const appRoutes: Routes = [
  {
    path: '',
    runGuardsAndResolvers: 'always',
    canActivate: [LogoutGuard],
    children: [
      { path: 'register', component: RegisterComponent },
      { path: 'home', component: HomeComponent },
      { path: '', component: HomeComponent }
    ]
  },

  {
    path: '',
    runGuardsAndResolvers: 'always',
    canActivate: [AuthGuard],
    children: [
      { path: 'main', component: MainComponent }
    ]
  },
  { path: '**', redirectTo: '', pathMatch: 'full'},
]
