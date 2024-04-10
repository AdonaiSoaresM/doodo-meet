<template lang="">
  <div class="relative flex items-center justify-center w-full h-full">
    <div
      class="w-[500px] h-full bg-white home-content shadow-2xl  flex flex-col"
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
import UserService from "@/common/services/User";

export default defineComponent({
  components: {
    Header,
    Content
  },
  mounted: async function(){
    await this.$websocket.start();
    await UserService.invoke_user();
    // this.$websocket.sendId(this.$keycloak.subject!)
    // this.$websocket.sendMessage(this.$keycloak.subject!, "fala");

    // this.$websocket.connection.on("ReceiveMessage", (message: string) => {
    //   console.log("Chegou: ", message);
    // })
  },
});
</script>
