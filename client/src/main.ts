import { bootstrapApplication } from '@angular/platform-browser';
import { appConfig } from './app/app.config';
import { LoginPage } from './app/start/login-page/login-page';

bootstrapApplication(LoginPage, appConfig)
  .catch((err) => console.error(err));
