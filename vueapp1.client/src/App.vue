<!--app.vue-->

<template>
    <div>
        <HeaderComponent />
        <router-view class="p-top" />
    </div>
</template>

<script setup>
    import HeaderComponent from './components/HeaderComponent.vue'
    import router from './router.js'
</script>

<style scoped>
    .p-top{
        padding-top: 45px;
    }
</style>
