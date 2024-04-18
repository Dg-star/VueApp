<!--<template>
    <div class="container">
        <h1 class="employee-card">
            <router-link to="/">Main page</router-link> /
            <router-link to="/employee-list">Employee list</router-link> / Employee card
        </h1>
        <div class="employee-info gray-background">
            <h2 class="gray-block">{{ employee.fullName }}<span class="status"> ({{ employee.status }})</span><img class="edit-icon" src="@/assets/edit.png" alt="Edit" @click="openEditModal"></h2>
            <p>Gender: {{ employee.gender }}</p>
            <p>Date of Birth: {{ employee.dateOfBirth }}</p>
            <p>Identifier: {{ employee.id }}</p>
            <p>Manager: {{ employee.manager }}</p>
            <p>Position: {{ employee.position }}</p>
            <p>Office: {{ employee.office }}</p>
            <p>Organization: {{ employee.organization }}</p>

            <h4>Contact Information</h4>
            <div class="separator"></div>
            <p>Mobile Phone: {{ employee.mobile }}</p>
            <p>Email Address: {{ employee.email }}</p>

            <div class="gray-background">
                <h3 class="gray-block">Appointments <img class="edit-icon" src="@/assets/edit.png" alt="Edit"></h3>
                <div v-for="(appointment, index) in employee.appointments" :key="index" class="appointment">
                    <h4>{{ appointment.type }}</h4>
                    <div class="separator"></div>
                    <p>Appointment: {{ appointment.title }}</p>
                    <p>Start Date: {{ appointment.startDate }}</p>
                    <p>End Date: {{ appointment.endDate }}</p>
                    <ul>
                        <li v-for="(absence, index) in appointment.absences" :key="index">{{ absence.reason }} from {{ absence.startDate }} to {{ absence.endDate }}</li>
                    </ul>
                </div>
            </div>

            <div class="gray-background">
                <h3 class="gray-block">Access Rights <img class="edit-icon" src="@/assets/edit.png" alt="Edit"></h3>
                <div class="roles">
                    <h4>Roles</h4>
                    <div class="separator"></div>
                    <p v-for="(role, index) in employee.roles" :key="index">{{ role.name }}, active from {{ role.startDate }} to {{ role.endDate }}</p>
                </div>

                <div class="own-permissions">
                    <h4>Own Permissions</h4>
                    <div class="separator"></div>
                    <p v-for="(permission, index) in employee.permissions" :key="index">{{ permission.name }}, active from {{ permission.startDate }} to {{ permission.endDate }}</p>
                </div>
            </div>

            <div class="gray-background">
                <h3 class="gray-block">Account Information <img class="edit-icon" src="@/assets/edit.png" alt="Edit"></h3>
                <div class="active-directory">
                    <h4>Active Directory <span class="status"> ({{ employee.adStatus }})</span></h4>
                    <div class="separator"></div>
                    <p>Identifier: {{ employee.adIdentifier }}</p>
                    <p>Account Validity: {{ employee.adValidity }}</p>
                    <p>Password Expiry: {{ employee.adPasswordExpiry }}</p>
                    <p>Last Login: {{ employee.adLastLogin }}</p>
                    <p>Last Password Change: {{ employee.adLastPasswordChange }}</p>
                </div>

                <div class="internal-storage">
                    <h4>Internal Storage</h4>
                    <div class="separator"></div>
                    <p>Identifier: {{ employee.internalStorageIdentifier }}</p>
                    <p>Account Validity: {{ employee.internalStorageValidity }}</p>
                    <p>Password Expiry: {{ employee.internalStoragePasswordExpiry }}</p>
                    <p>Password Change Required: {{ employee.internalStoragePasswordChangeRequired }}</p>
                    <p>Last Login: {{ employee.internalStorageLastLogin }}</p>
                    <p>Last Password Change: {{ employee.internalStorageLastPasswordChange }}</p>
                    <p>Work Schedule: {{ employee.workSchedule }}</p>
                </div>
            </div>
        </div>
        <div v-if="showEditModal" class="modal" style="left: 20px; top: 50px;">
            <div class="modal-content">
                <span class="close" @click="closeModal">&times;</span>
                <edit-employee-form :employee="employee" @close="closeModal" />
            </div>
        </div>
    </div>
</template>-->

<template>
    <div class="container">
        <h1 class="employee-card">
            <router-link to="/">Main page</router-link> /
            <router-link to="/employee-list">Employee list</router-link> / Employee card
        </h1>
        <div v-if="employee" class="employee-info gray-background">
            <h2 class="gray-block">{{ employee.fullname }}<span class="status"> ({{ employee.status_name }})</span><img class="edit-icon" src="@/assets/edit.png" alt="Edit" @click="openEditModal"></h2>
            <p>Phone Number: {{ employee.phone_number }}</p>
            <p>Email: {{ employee.email }}</p>
            <p>Status Owner: {{ employee.status_owner }}</p>
            <p>Cabinet: {{ employee.cabinet }}</p>
            <p>Job Title: {{ employee.job_title }}</p>
            <p>Supervisor: {{ employee.supervisor }}</p>
            <p>Organization: {{ employee.organization }}</p>

            <h4>Contact Information</h4>
            <div class="separator"></div>
            <p>Mobile Phone: {{ employee.phone_number }}</p>
            <p>Email Address: {{ employee.email }}</p>
        </div>
    </div>
</template>

<script>
    import EditEmployeeForm from '@/components/EditEmployeeForm.vue';
    import axios from 'axios';

    export default {
        name: 'EmployeeCard',
        components: {
            EditEmployeeForm,
        },
        props: {
            id: String,
        },
        data() {
            return {
                employee: null,
                showEditModal: false,
            };
        },
        mounted() {
            this.fetchEmployeeData();
        },
        methods: {
            async fetchEmployeeData() {
                try {
                    const response = await axios.get(`/api/employees/${this.id}`);
                    this.employee = response.data;
                } catch (error) {
                    console.error('Error fetching employee data:', error);
                }
            },
            openEditModal() {
                this.showEditModal = true;
            },
            closeModal() {
                this.showEditModal = false;
            },
        },
    };
</script>

<style scoped>
    body {
        font-family: Arial, sans-serif;
        margin: 0;
        padding: 0;
    }

    .container {
        max-width: 800px;
        margin: 20px auto;
        padding: 20px;
    }

    .modal {
        position: fixed;
        z-index: 9999;
        background-color: white;
        width: 450px;
        padding: 20px;
        border-radius: 8px;
        box-shadow: 0 2px 4px rgba(0,0,0,0.1);
    }

    header {
        background-color: #333;
        color: #fff;
        padding: 10px;
    }

    .header-content {
        display: flex;
        justify-content: space-between;
        align-items: center;
    }

    .logo {
        display: flex;
        align-items: center;
    }

        .logo img {
            width: 30px;
            height: 30px;
            margin-right: 10px;
        }

    .header-title {
        font-size: 24px;
    }

    .bigger {
        font-size: 28px;
    }

    .employee-info {
        background-color: #f0f0f0;
        padding: 20px;
        border-radius: 8px;
    }

    .status {
        color: gray;
    }

    .edit-icon {
        float: right;
        color: blue;
        cursor: pointer;
    }

    .appointments,
    .permissions,
    .user-data {
        margin-top: 20px;
    }

    .appointment,
    .roles,
    .own-permissions {
        margin-bottom: 20px;
    }

    .active-directory,
    .internal-storage {
        margin-top: 20px;
        padding-top: 20px;
    }

        .active-directory h4,
        .internal-storage h4 {
            margin-top: 0;
        }

    .edit-icon {
        cursor: pointer;
        width: 30px;
        height: 30px;
    }

    .separator {
        height: 1px;
        background-color: #ccc;
        margin: 0 0 10px 0;
    }

    .gray-background {
        background-color: #f0f0f0;
        padding: 20px;
        border-radius: 8px;
    }

    .gray-block {
        background-color: #c0c0c0;
        padding: 10px;
        border-radius: 8px;
    }
</style>
