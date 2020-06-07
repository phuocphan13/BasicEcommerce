import { Component, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export class ProductService {
    homeAddress = 'api/Product';
    apiHost = "https://localhost:44371";

    constructor(public http: HttpClient) {
    }

    get(): Observable<any> {
        return this.http.get(`${this.apiHost}/${this.homeAddress}`);
    }
}
