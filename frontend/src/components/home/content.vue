<template>
  <div
    class="flex items-center justify-between w-full h-20 px-7 bg-teal-950"
  ></div>
</template>
<script lang="ts">
import { defineComponent } from "vue";
import svgVue from "../ui/svg.vue";

export default defineComponent({
  name: "Header",
  components: {
    svgVue,
  },
});
</script>
