import { Routes } from '@angular/router';
import { Demo } from './demo';
import { Counter } from './pages/counter';
export const demos_routes: Routes = [
  {
    path: '',
    component: Demo,
    children: [
      {
        path: 'counter',
        component: Counter,
      },
    ],
  },
];
