import {
  Component,
  ChangeDetectionStrategy,
  signal,
  computed,
} from '@angular/core';

@Component({
  selector: 'app-demos-counter',
  changeDetection: ChangeDetectionStrategy.OnPush,
  imports: [],
  template: `
    <div>
      <button (click)="decrement()" class="btn btn-warning btn-circle">
        -
      </button>
      <span class="px-4">{{ current() }}</span>
      <button (click)="increment()" class="btn btn-success btn-circle">
        +
      </button>
    </div>

    <div>
      @if (isEven()) {
        <p>It is Even</p>
      } @else {
        <p>It is Odd!</p>
      }
    </div>
  `,
  styles: ``,
})
export class Counter {
  current = signal(0);

  isEven = computed(() => this.current() % 2 === 0);

  decrement() {
    this.current.update((c) => c - 1);
  }

  increment() {
    this.current.update((c) => c + 1);
  }
}
