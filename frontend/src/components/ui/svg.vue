<template lang="">
  <svg :width :height viewBox="0 0 24 24">
    <path :fill="color" :d="svg" />
  </svg>
</template>
<script lang="ts">
import { defineComponent } from "vue";

export default defineComponent({
  name: "Svg",
  props: {
    svg: {
      type: String,
      required: true,
    },
    color: {
      type: String,
      default: "black",
    },
    width: {
      type: String,
      default: "24",
    },
    height: {
      type: String,
      default: "24",
    },
  },
});
</script>
