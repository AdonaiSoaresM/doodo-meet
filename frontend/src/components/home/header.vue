<template>
  <div class="flex items-center justify-between w-full h-20 px-7 bg-teal-950">
    <div class="flex items-center gap-4">
      <Avatar class="w-12 h-12">
        <AvatarImage src="https://github.com/radix-vuee.png" alt="@radix-vue" />
        <AvatarFallback><span class="font-medium"> CN </span></AvatarFallback>
      </Avatar>
      <span class="font-medium text-white">Juliano Almeida</span>
    </div>
    <HeaderButtons />
  </div>
</template>
<script lang="ts">
import { defineComponent } from "vue";
import { Avatar, AvatarFallback, AvatarImage } from "@/components/ui/avatar";
import HeaderButtons from "./header-buttons.vue";
export default defineComponent({
  components: {
    Avatar,
    AvatarFallback,
    AvatarImage,
    HeaderButtons,
  },
});
</script>
