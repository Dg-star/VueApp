<template>
    <h1 class="employee-card">
        <router-link to="/">Main page</router-link> /
        <router-link to="/employee-list">Employee list</router-link> / Employee card
    </h1>
    <div>
        <h2>{{ employee.name }}</h2>
        <p>Identifier: {{ employee.id }}</p>
        <p>Contacts: {{ employee.contacts }}</p>
        <p>Employment: {{ employee.employment }}</p>
        <p>Roles Count: {{ employee.rolesCount }}</p>
        <p>Access Rights Count: {{ employee.accessRightsCount }}</p>
        <p>Account Count: {{ employee.accountCount }}</p>
    </div>
</template>

<script>
    export default {
        name: 'EmployeeCard',
        props: {
            id: String // Определение свойства id
        },
        data() {
            return {
                employee: {
                    name: 'Ivanov Ivan Ivanovich',
                    id: this.id, // Использование переданного id
                    contacts: '+79123456789',
                    employment: 'Manager, Astrologer, Programmer',
                    rolesCount: 3,
                    accessRightsCount: 4,
                    accountCount: 2
                }
            };
        }
    }
</script>

<style scoped>

    .employee-card{
        padding-top: 40px;
    }

</style>
