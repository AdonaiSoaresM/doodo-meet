<template>
  <main class="w-screen h-screen">
    <RouterView />
  </main>
</template>

<script setup lang="ts">
import { RouterView } from "vue-router";
</script>
<style scoped>
main {
  background-image: url("@/assets/images/background.png");
}
</style>
