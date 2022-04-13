import { AbstractControl, FormGroup } from '@angular/forms';

export class ValidatorField {
    static MustMatch(controlName: string, MatchingControlName: string): any {
        return (group: AbstractControl) => {
            const formGroup = group as FormGroup;
            const control = formGroup.controls[controlName];
            const machingControl = formGroup.controls[MatchingControlName];

            if (machingControl.errors && !machingControl.errors.mustMatch) {
                return null;
            }
            if (control.value !== machingControl.value) {
                machingControl.setErrors({ MustMatch: true })
            }
            else {
                machingControl.setErrors(null)
            }
            return null;
        }
    };
}