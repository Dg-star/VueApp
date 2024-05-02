<template>
    <div class="edit-employee-form gray-background">
        <h2 class="form-title">Edit Employee</h2>
        <form @submit.prevent="submitForm" class="form">
            <div class="form-group">
                <label for="fullName" class="form-label">Full Name:</label>
                <input type="text" v-model="editedEmployee.fullname" id="fullName" class="form-input">
            </div>



            <div class="form-group">
                <label for="statusOwner" class="form-label">Status Owner:</label>
                <input type="text" id="statusOwner" class="form-input">
            </div>

            <div class="form-group">
                <label for="cabinet" class="form-label">Cabinet:</label>
                <input type="text" v-model="editedEmployee.cabinet" id="cabinet" class="form-input">
            </div>

            <div class="form-group">
                <label for="jobTitle" class="form-label">Job Title:</label>
                <input type="text" v-model="editedEmployee.job_title" id="jobTitle" class="form-input">
            </div>

            <div class="form-group">
                <label for="supervisor" class="form-label">Supervisor:</label>
                <input type="text" v-model="editedEmployee.supervisor" id="supervisor" class="form-input">
            </div>

            <div class="form-group">
                <label for="organization" class="form-label">Organization:</label>
                <input type="text" v-model="editedEmployee.organization" id="organization" class="form-input">
            </div>
            <h4>Contact Information:</h4>
            <div class="form-group">
                <label for="phone_number" class="form-label">Phone Number:</label>
                <input type="text" v-model="editedEmployee.phone_number" id="phone_number" class="form-input">
            </div>

            <div class="form-group">
                <label for="email" class="form-label">Email:</label>
                <input type="text" v-model="editedEmployee.email" id="email" class="form-input">
            </div>
            <!-- Продолжайте добавлять остальные поля формы здесь -->

            <button type="submit" class="btn-submit">Save</button>
        </form>
    </div>
</template>

<script>
    import axios from 'axios';

    export default {
        name: 'EditEmployeeForm',
        props: {
            employee: Object,
        },
        data() {
            return {
                editedEmployee: {
                    ...this.employee,
                    id: this.employee.user_id
                }, // Копируем данные сотрудника для редактирования                
            };
        },
        methods: {
            async submitForm() {
                try {
                    // Отправляем данные формы на сервер
                    const response = await axios.put(`/api/employees/${this.editedEmployee.id}`, this.editedEmployee);
                    console.log('Employee data updated:', this.editedEmployee);
                    this.$emit('close');
                    window.location.reload()
                } catch (error) {
                    console.error('Error updating employee data:', error);
                }
            },
        },
    };
</script>


<style scoped>
    .edit-employee-form {
        max-width: 400px;
        margin: 0 auto;
    }

    .form-title {
        font-size: 24px;
        margin-bottom: 20px;
        color: #333;
    }

    .form {
        width: 100%;
    }

    .form-group {
        margin-bottom: 20px;
    }

    .form-label {
        display: block;
        font-size: 16px;
        margin-bottom: 5px;
        color: #555;
    }

    .form-input {
        width: 90%;
        padding: 10px;
        border: 1px solid #ccc;
        border-radius: 5px;
        font-size: 16px;
    }

    .btn-submit {
        background-color: #007bff;
        color: #fff;
        padding: 10px 20px;
        border: none;
        border-radius: 5px;
        cursor: pointer;
        font-size: 16px;
    }

        .btn-submit:hover {
            background-color: #0056b3;
        }

    .gray-background {
        background-color: #f0f0f0;
        padding: 20px;
        border-radius: 8px;
    }
</style>