import { Component, ChangeDetectionStrategy } from '@angular/core';

@Component({
  selector: 'app-demos-counter',
  changeDetection: ChangeDetectionStrategy.OnPush,
  imports: [],
  template: `
    <div>
      <button class="btn btn-warning btn-circle">-</button>
      <span class="px-4">0</span>
      <button class="btn btn-success btn-circle">+</button>
    </div>
  `,
  styles: ``,
})
export class Counter {}
