import { createRouter, createWebHistory } from 'vue-router'
import MainComponent from './components/MainComponent.vue'
import EmployeeList from './components/EmployeeList.vue'
import EmployeeCard from './components/EmployeeCard.vue'

const routes = [
    { path: '/', component: MainComponent },
    { path: '/employee-list', component: EmployeeList },
    { path: '/employee/:id', name: 'EmployeeCard', component: EmployeeCard, props: true }
]

const router = createRouter({
    history: createWebHistory(),
    routes
})

export default router
