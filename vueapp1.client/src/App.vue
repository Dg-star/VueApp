<script setup>
    //import ContentComponent from './components/ContentComponent.vue'
    import HeaderComponent from './components/HeaderComponent.vue'
    //import ScreenComponent from './components/ScreenComponent.vue'
</script>   

<template>
    <header>
        <HeaderComponent />
    </header>

    <main>
    </main>
</template>

<style scoped>
    body {
        font-family: Arial, sans-serif;
        margin: 0;
        padding: 0;
    }

    header {
        background-color: #333;
        color: #fff;
        padding: 10px;
    }

    main {
        display: grid;
        grid-template-columns: repeat(2, 20%);
        justify-content: center;
        align-items: center;
        gap: 10px;
        margin-top: 20px;
    }

</style>
