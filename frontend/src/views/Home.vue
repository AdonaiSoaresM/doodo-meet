<template lang="">
  <div class="relative flex items-center justify-center w-full h-full">
    <div
      class="w-[500px] h-full bg-white home-content shadow-2xl shadow-zinc-200"
    >
      <Header />
    </div>
  </div>
</template>
<script lang="ts">
import { defineComponent } from "vue";
import Header from "@/components/home/header.vue";

export default defineComponent({
  name: "Home",
  components: {
    Header,
  },
});
</script>
<style scoped>
.home-content {
  background-position: center;
  background-image: url("@/assets/images/marketing-cuate.png");
  background-size: 100%;
  background-repeat: no-repeat;
}
</style>
