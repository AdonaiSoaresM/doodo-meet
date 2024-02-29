<template lang="">
  <div>Home</div>
</template>
<script lang="ts">
import { defineComponent } from "vue";

export default defineComponent({
  name: "Home",
  mounted() {
    this.$router.push("/login")
  },
});
</script>
