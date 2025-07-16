import { HttpClient } from '@angular/common/http';
import { inject } from '@angular/core';

export type LinkApiItem = {
  id: string;
  href: string;
  description: string;
};

export class LinksApiService {
  #http = inject(HttpClient);
  getLinks() {
    return this.#http.get<LinkApiItem[]>(
      'http://api.realsever-but-not-really.com/links',
    );
  }
}
