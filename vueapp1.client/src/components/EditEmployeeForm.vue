<template>
    <div class="edit-employee-form gray-background">
        <h2 class="form-title">Edit Employee</h2>
        <form @submit.prevent="submitForm" class="form">
            <div class="form-group">
                <label for="fullName" class="form-label">Full Name:</label>
                <input type="text" v-model="editedEmployee.fullName" id="fullName" class="form-input">
            </div>

            <div class="form-group">
                <label for="status" class="form-label">Status:</label>
                <input type="text" v-model="editedEmployee.status" id="status" class="form-input">
            </div>

            <div class="form-group">
                <label for="gender" class="form-label">Gender:</label>
                <input type="text" v-model="editedEmployee.gender" id="gender" class="form-input">
            </div>

            <!-- ѕродолжайте добавл€ть остальные пол€ формы здесь -->

            <button type="submit" class="btn-submit">Save</button>
        </form>
    </div>
</template>

<script>
    export default {
        name: 'EditEmployeeForm',
        props: {
            employee: Object,
        },
        data() {
            return {
                editedEmployee: { ...this.employee }, //  опируем данные сотрудника дл€ редактировани€
            };
        },
        methods: {
            submitForm() {
                // «десь должна быть логика сохранени€ изменений в базу данных
                console.log('Employee data updated:', this.editedEmployee);
                // «акрываем модальное окно после сохранени€
                this.$emit('close');
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