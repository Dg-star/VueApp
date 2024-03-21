<template>
    <div class="screen">
        <div class="square">
            <h2>{{ screen.title }}</h2>
            <ul>
                <li v-for="(item, index) in screen.items" :key="index">{{ item }}</li>
            </ul>
        </div>
    </div>
</template>

<script>
export default {
  name: 'ScreenComponent',
  props: ['screen'],
}
</script>

<style scoped>
</style>
