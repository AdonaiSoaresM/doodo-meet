<template>
  <div class="flex items-center justify-between w-full h-20 px-7 bg-teal-950">
    <Avatar class="w-12 h-12">
      <AvatarImage src="https://github.com/radix-vuee.png" alt="@radix-vue" />
      <AvatarFallback><span class="font-medium"> CN </span></AvatarFallback>
    </Avatar>
    <div class="flex gap-3">
      <svgVue color="white" :svg="$icons.mdiAccountMultiplePlus"/>
      <svgVue color="white" :svg="$icons.mdiMessagePlus"/>
    </div>
  </div>
</template>
<script lang="ts">
import { defineComponent } from "vue";
import { Avatar, AvatarFallback, AvatarImage } from "@/components/ui/avatar";
import svgVue from "../ui/svg.vue";

export default defineComponent({
  name: "Header",
  components: {
    Avatar,
    AvatarFallback,
    AvatarImage,
    svgVue
  },
});
</script>
