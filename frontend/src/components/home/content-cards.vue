<template>
    <div class="flex items-center justify-between w-full py-3 bg-teal-800 shadow-md rounded-xl px-7">
        <div class="flex items-center gap-3">
            <Avatar class="w-12 h-12">
              <AvatarImage src="https://github.com/radix-vuee.png" alt="@radix-vue" />
              <AvatarFallback><span class="font-medium"> CN </span></AvatarFallback>
            </Avatar>
            <span class="font-medium text-white">João Bosco</span>
        </div>
      </div>
  </template>
  <script lang="ts">
  import { defineComponent } from "vue";
  import { Avatar, AvatarFallback, AvatarImage } from "@/components/ui/avatar";

  export default defineComponent({
    components: {
      Avatar,
      AvatarFallback,
      AvatarImage,
    },
  });
  </script>
