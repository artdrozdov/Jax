import { Component, OnInit } from '@angular/core';

import { EntriesService } from '../shared/entries.service';
import { Entry } from '../shared/entries.service';

@Component({
    moduleId: module.id,
    templateUrl: 'home.component.html'
})
export class HomeComponent implements OnInit {
    characters: string[];
    entries: Entry[];

    constructor(private entriesService: EntriesService) { }

    ngOnInit() {
        this.entriesService.getEntries()
            .subscribe(entries =>{this.entries = entries; entries.forEach(e => console.log(e)); });
    }
}