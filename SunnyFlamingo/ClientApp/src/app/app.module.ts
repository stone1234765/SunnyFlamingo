import { BrowserModule } from '@angular/platform-browser';
import { APP_INITIALIZER, NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { ReactiveFormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';

import { GoodsModule } from './goods/goods.module';
import { AppRoutingModule } from './app-routing.module';
import { NavbarModule } from './navbar/navbar.module';
import { DynamicFormModule } from './dynamicForms/dynamic-form.module';
import { NgxSliderModule } from '@angular-slider/ngx-slider';
import { LoaderModule } from './loader/loader.module';
import { GoodModule } from './good/good.module';
import { CheckoutComponent } from './checkout/checkout/checkout.component';
import { AuthModule, LogLevel, OidcConfigService } from 'angular-auth-oidc-client';

export function configureAuth(oidcConfigService: OidcConfigService) {
  return () =>
    oidcConfigService.withConfig({
      stsServer: 'https://localhost:44379',
      responseType: 'id_token token',
      redirectUrl: window.location.origin,
      postLogoutRedirectUri: window.location.origin,
      silentRenew: true,
      silentRenewUrl: `${window.location.origin}/silent-renew.html`,
      clientId: 'angularClient',
      scope: 'openid profile',
      logLevel: LogLevel.Debug,
    });
}

@NgModule({
  declarations: [
    AppComponent,
    PageNotFoundComponent,
    CheckoutComponent,
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    ReactiveFormsModule,
    HttpClientModule,
    DynamicFormModule,
    NgxSliderModule,
    AuthModule.forRoot(),
    LoaderModule,
    NavbarModule,
    GoodsModule,
    GoodModule,
    AppRoutingModule,
  ],
  providers: [
    OidcConfigService,
    {
      provide: APP_INITIALIZER,
      useFactory: configureAuth,
      deps: [OidcConfigService],
      multi: true,
    },
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
