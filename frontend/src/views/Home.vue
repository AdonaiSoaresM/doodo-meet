<template lang="">
  <div class="relative flex items-center justify-center w-full h-full">
    <div
      class="w-[500px] h-full bg-white home-content shadow-2xl shadow-zinc-200 flex flex-col"
    >
      <Header />
      <Content />
    </div>
  </div>
</template>
<script lang="ts">
import { defineComponent } from "vue";
import Header from "@/components/home/header.vue";
import Content from "@/components/home/content.vue";

export default defineComponent({
  components: {
    Header,
    Content
  },
});
</script>
