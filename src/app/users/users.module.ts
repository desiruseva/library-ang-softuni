import { NgModule } from '@angular/core';
import { UserOrdersComponent } from './user-orders/user-orders.component';
import { SharedModule } from '../shared/shared.module';
import { ProfileComponent } from './profile/profile.component';
import { AllOrdersComponent } from './all-orders/all-orders.component';
import { ApprovalRequestsComponent } from './approval-requests/approval-requests.component';
import { ViewUsersComponent } from './view-users/view-users.component';

@NgModule({
  declarations: [
    UserOrdersComponent,
    ProfileComponent,
    AllOrdersComponent,
    ApprovalRequestsComponent,
    ViewUsersComponent,
    ProfileComponent,
    ApprovalRequestsComponent,
    AllOrdersComponent,
    ViewUsersComponent,
  ],
  imports: [SharedModule],
})
export class UsersModule {}
