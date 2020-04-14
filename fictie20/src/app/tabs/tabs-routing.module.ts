import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TabsPage } from './tabs.page';

const routes: Routes = [
  {
    path: 'tabs',
    component: TabsPage,
    children: [
      {
        path: 'login',
        children: [
          {
            path: '',
            loadChildren: () =>
              import('../login/login.module').then(m => m.LoginPageModule)
          }
        ]
      },
      {
        path: 'module',
        children: [
          {
            path: '',
            loadChildren: () =>
              import('../module/modules.module').then(m => m.modulePageModule)
          }
        ]
      },
      {
        path: 'pi',
        children: [
          {
            path: '',
            loadChildren: () =>
              import('../pi/pi.module').then(m => m.piPageModule)
          }
        ]
      },
      {
        path: 'activiteit',
        children: [
          {
            path: '',
            loadChildren: () =>
              import('../activiteit/activiteit.module').then(m => m.activiteitPageModule)
          }
        ]
      },
      {
        path: 'procesVerbaal',
        children: [
          {
            path: '',
            loadChildren: () =>
              import('../procesVerbaal/procesVerbaal.module').then(m => m.procesVerbaalPageModule)
          }
        ]
      },
      {
        path: '',
        redirectTo: '/tabs/login',
        pathMatch: 'full'
      }
    ]
  },
  {
    path: '',
    redirectTo: '/tabs/login',
    pathMatch: 'full'
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TabsPageRoutingModule {}
