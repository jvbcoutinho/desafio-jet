import { Component, OnInit } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { LoadingService } from './services/loading.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit  {
  title = 'BlueModas';
  isLoading: BehaviorSubject<boolean>;

  constructor(private loadingService: LoadingService){}

  ngOnInit(): void {
    this.isLoading = this.loadingService.isLoading;
  }
}
