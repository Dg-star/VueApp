<!--EmployeeList.vue-->


<template>
    <main>
        <h1>
            <router-link to="/">Main page</router-link> / Employee list
        </h1>
        <div class="table-container">
            <table>
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Identifier</th>
                        <th>Contacts</th>
                        <th>Employment</th>
                        <th>Roles Count</th>
                        <th>Access Rights Count</th>
                    </tr>
                </thead>
                <tbody>
                    <tr v-for="(employee, index) in employees" :key="index">
                        <td>
                            <router-link :to="{ name: 'EmployeeCard', params: { id: employee.user_id }}">{{ employee.fullname }}</router-link>
                        </td>
                        <td>{{ employee.user_id }}</td>
                        <td>{{ employee.phone_number }}</td>
                        <td>{{ employee.email }}</td>
                        <td>{{ employee.status_id }}</td>
                        <td>{{ employee.supervisor }}</td>
                    </tr>
                </tbody>
            </table>
        </div>
        <div class="pagination">
            <button>&laquo; Previous</button>
            <span>1 of 10</span>
            <button>Next &raquo;</button>
        </div>
    </main>
</template>

<script>
    import axios from "axios";
    export default {
        name: 'EmployeeList',
        data() {
            return {
                employees: []
            };
        },
        created() {
            this.fetchEmployees();
        },
        methods: {
            async fetchEmployees() {
                try {
                    const response = await axios.get('/api/employees');
                    this.employees = response.data;
                    console.log(this.employees[0]);
                } catch (error) {
                    console.error('Error fetching employees:', error);
                }
            }
        }
    }
</script>

<!--async fetchEmployees() {
    try {
        const response = await fetch('/api/employees'); // Обратите внимание на начальный слэш здесь
        if (!response.ok) {
            throw new Error('Network response was not ok');
        }
        const data = await response.json();
        console.log("Response data:", data);
        this.employees = data;
    } catch (error) {
        console.error('Error fetching employees:', error);
    }
}-->


<style scoped>
    main {
        padding: 20px;
    }

    h1 {
        margin-top: 0;
    }

    .table-container {
        overflow-x: auto;
    }

    table {
        width: 100%;
        border-collapse: collapse;
    }

    th, td {
        padding: 8px;
        text-align: left;
    }

    th {
        border-bottom: 1px solid #ddd;
        background-color: #f2f2f2;
        color: #333;
    }

    tr:nth-child(even) {
        background-color: #f9f9f9;
    }

    .pagination {
        margin-top: 20px;
        text-align: right;
    }

        .pagination button {
            background-color: #f2f2f2;
            border: none;
            color: #333;
            padding: 8px 16px;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 16px;
            margin: 4px 2px;
            cursor: pointer;
            border-radius: 4px;
        }

            .pagination button:hover {
                background-color: #ddd;
            }
</style>
