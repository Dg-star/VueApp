<template>

        <header>
            <div class="logo">
                <img src="/src/assets/menu-icon.png" alt="Menu">
                <span class="header-title bigger"><!--Служба управления доступом сотрудников--> Employee Access Control Service </span>
            </div>
            <div class="account">
                <span><!--Иванов Иван Иванович--> Ivanov Ваня Ivanovich </span>
            </div>
        </header>

</template>

<script>
    export default {
        name: 'HeaderComponent',
    }
</script>

<style scoped>
    header {
        display: flex;
        justify-content: space-between;
        align-items: center;
        width: 100%;
        padding: 10px;
        box-sizing: border-box;
        background-color: #333;
        color: #fff;
        position: fixed;
        top: 0;
        left: 0;
        right: 0;
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
        flex-grow: 1;
        font-size: 24px;
    }

    .bigger {
        font-size: 28px;
    }

    main {
        margin-top: 70px; 
        display: flex;
        justify-content: center;
        align-items: center;
        height: calc(100vh - 70px); 
    }

</style>