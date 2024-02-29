<template>
  <div class="relative flex flex-1 w-full div-content">
    <img class="absolute z-0 w-full h-full img-content" />
    <div class="z-10 flex flex-col w-full gap-4 px-8 py-6 overflow-scroll">
      <ContentCards />
      <ContentCards />
      <ContentCards />
      <ContentCards />
      <ContentCards />
      <ContentCards />
      <ContentCards />
      <ContentCards />
      <ContentCards />
      <ContentCards />
      <ContentCards />
      <ContentCards />
      <ContentCards />
    </div>
  </div>
</template>
<script lang="ts">
import { defineComponent } from "vue";
import ContentCards from "./content-cards.vue";

export default defineComponent({
  components: {
    ContentCards,
  },
});
</script>
<style scoped>
.img-content {
  background-position: center;
  background-image: url("@/assets/images/marketing-cuate.png");
  background-size: 100%;
  background-position: top;
  background-repeat: no-repeat;
  opacity: 0.2;
}

.div-content{
  height: calc(100% - 80px);
}

</style>
