import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';

@Injectable()
export class EntriesService {
    
    constructor(private http: Http) { }

    getEntries() {
        return this.http.get('api/entries')
            .map(response => <Entry[]>response.json());
    }
}

export class Entry {
    public Href: string;
    public Title: string;
    public Description: string;
}