import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Observable } from 'rxjs';
import { PropertyService } from '../property.service';
import { PropertyTypeService } from '../propertyType.service';
import { Property } from '../property';
import { PropertyType } from '../propertyType';

@Component({
  selector: 'app-property',
  templateUrl: './property.component.html',
  styleUrls: ['./property.component.css']
})
export class PropertyComponent implements OnInit {
  dataSaved = false;
  propertyForm: any;
  allProperties: Property[];
  allPropertyTypes: PropertyType[];
  propertyIdUpdate = null;
  massage = null;
  students=[];
  constructor(private formbulider: FormBuilder, private propertyService: PropertyService
    , private propertyTypeService: PropertyTypeService) { }

  ngOnInit() {
    this.propertyForm = this.formbulider.group({
      Name: ['', [Validators.required]],
      Description: ['', [Validators.required]],
      Address: ['', [Validators.required]],
      Owner: ['', [Validators.required]],
      RoomCount: ['', [Validators.required]],
      DateOnMarket: ['', [Validators.required]],
      PropertyTypeId: ['', [Validators.required]]
    });
    this.loadAllProperties();
  }
  loadAllProperties() {
    this.propertyService.getAllProperties()
                                          .subscribe(res=> this.allProperties = res);

    this.propertyTypeService.getAllPropertyTypes()
                                          .subscribe(res=> this.allPropertyTypes = res);
  }
  onFormSubmit() {
    this.dataSaved = false;
    const property = this.propertyForm.value;
    this.CreateProperty(property);
    this.propertyForm.reset();
  }
  loadPropertyToEdit(propertyId: string) {
    this.propertyService.getPropertyById(propertyId).subscribe(property => {
      this.massage = null;
      this.dataSaved = false;
      this.propertyIdUpdate = property.PropertyId;
      this.propertyForm.controls['Name'].setValue(property.Name);
      this.propertyForm.controls['Description'].setValue(property.Description);
      this.propertyForm.controls['Address'].setValue(property.Address);
      this.propertyForm.controls['Owner'].setValue(property.Owner);
      this.propertyForm.controls['RoomCount'].setValue(property.RoomCount);
      this.propertyForm.controls['DateOnMarket'].setValue(property.DateOnMarket);
      this.propertyForm.controls['PropertyTypeId'].setValue(property.PropertyTypeId);
    });

  }
  CreateProperty(property: Property) {
    if (this.propertyIdUpdate == null) {
      this.propertyService.createProperty(property).subscribe(
        () => {
          this.dataSaved = true;
          this.massage = 'Record saved Successfully';
          this.loadAllProperties();
          this.propertyIdUpdate = null;
          this.propertyForm.reset();
        }
      );
    } else {
      property.PropertyId = this.propertyIdUpdate;
      this.propertyService.updateProperty(property).subscribe(() => {
        this.dataSaved = true;
        this.massage = 'Record Updated Successfully';
        this.loadAllProperties();
        this.propertyIdUpdate = null;
        this.propertyForm.reset();
      });
    }
  }

  deleteProperty(propertyId: string) {
    if (confirm("Are you sure you want to delete this ?")) {
    this.propertyService.deletePropertyById(propertyId).subscribe(() => {
      this.dataSaved = true;
      this.massage = 'Record Deleted Succefully';
      this.loadAllProperties();
      this.propertyIdUpdate = null;
      this.propertyForm.reset();

    });
  }
}
  resetForm() {
    this.propertyForm.reset();
    this.massage = null;
    this.dataSaved = false;
  }

  numberOnly(event): boolean {
    const charCode = (event.which) ? event.which : event.keyCode;
    if (charCode > 31 && (charCode < 48 || charCode > 57)) {
      return false;
    }
    return true;

  }
}
