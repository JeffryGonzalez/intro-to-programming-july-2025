import { inject } from '@angular/core';
import { patchState, signalStore, withHooks, withMethods } from '@ngrx/signals';
import { setEntities, withEntities } from '@ngrx/signals/entities';
import { rxMethod } from '@ngrx/signals/rxjs-interop';
import { exhaustMap, pipe, tap } from 'rxjs';
import { LinkApiItem, LinksApiService } from './links-api';

export const LinksStore = signalStore(
  withEntities<LinkApiItem>(),

  withMethods((store) => {
    const service = inject(LinksApiService);
    return {
      _load: rxMethod<void>(
        pipe(
          exhaustMap(() =>
            service
              .getLinks()
              .pipe(tap((links) => patchState(store, setEntities(links)))),
          ),
        ),
      ),
    };
  }),
  withHooks({
    onInit(store) {
      store._load();
    },
  }),
);
