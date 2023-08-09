import { Routes } from "@angular/router";
import { HomeComponent } from "./home/home.component";
import { RegisterComponent } from "./register/register.component";
import { MainComponent } from "./main/main.component";
import { AuthGuard } from "./_guards/auth.guard";
import { LogoutGuard } from "./_guards/logout.guard";

export const appRoutes: Routes = [
  { path: 'home', component: HomeComponent, canActivate: [LogoutGuard] },
  { path: 'main', component: MainComponent, canActivate: [AuthGuard] },
  { path: 'register', component: RegisterComponent, canActivate: [LogoutGuard] }, 
  { path: '**', redirectTo: 'home', pathMatch: 'full'},
]
