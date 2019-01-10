import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {MatButtonModule, MatCheckboxModule} from '@angular/material';
import { FormsModule } from '@angular/forms';
import {MatProgressBarModule} from '@angular/material';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import {MatToolbarModule} from '@angular/material/toolbar';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { AgentComponent } from './agent/agent.component';
import { ConfidenceComponent } from './confidence/confidence.component';
import { InterpretationComponent } from './interpretation/interpretation.component';
import {MatDividerModule} from '@angular/material/divider';
import { ScopeComponent } from './scope/scope.component';
import { FooterComponent } from './footer/footer.component';
import { HeaderComponent } from './header/header.component';
import { RibbonNavComponent } from './ribbon-nav/ribbon-nav.component';
import { InProgressComponent } from './in-progress/in-progress.component';
import { CompletedComponent } from './completed/completed.component';
import {MatTabsModule} from '@angular/material/tabs';
import {MatTooltipModule} from '@angular/material/tooltip';
import 'hammerjs';
import { ProgressbarComponent } from './progressbar/progressbar.component';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    ConfidenceComponent,
    InterpretationComponent,
    AgentComponent,
    ConfidenceComponent,
    InterpretationComponent,
    ScopeComponent,
    FooterComponent,
    HeaderComponent,
    RibbonNavComponent,
    InProgressComponent,
    CompletedComponent,
    ProgressbarComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    MatButtonModule, 
    MatCheckboxModule,
    BrowserAnimationsModule,
    MatProgressBarModule,
    MatTooltipModule,
    MatTabsModule,
    MatToolbarModule,
    MatDividerModule,
    FormsModule,
    RouterModule.forRoot([
      //{ path: '', component: AppComponent, pathMatch: 'full' },
      { path: 'agent', component: AgentComponent },
      { path: 'interpretation', component: InterpretationComponent },
      { path: 'confidence', component: ConfidenceComponent },
      { path: 'scope', component: ScopeComponent },
      { path: 'ribbon', component: RibbonNavComponent },
      { path: 'in-progress', component: InProgressComponent },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
