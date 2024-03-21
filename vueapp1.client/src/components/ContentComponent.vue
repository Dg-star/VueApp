<template>
    <div class="content">
        <screen-component v-for="(screen, index) in screens" :key="index" :screen="screen"></screen-component>
    </div>
</template>

<script>
export default {
  name: 'ContentComponent',
}
</script>

<style scoped>
</style>
