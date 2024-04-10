<template>
    <div class="flex items-center justify-between w-full py-3 bg-teal-800 shadow-md rounded-xl px-7">
        <div class="flex items-center gap-3">
            <Avatar class="w-12 h-12">
              <AvatarImage src="https://github.com/radix-vuee.png" alt="@radix-vue" />
              <AvatarFallback><span class="font-medium"> {{ initials }} </span></AvatarFallback>
            </Avatar>
            <span class="font-medium text-white">{{ user.name }}</span>
        </div>
        <div :class="{'w-3 h-3 rounded-full': true, 'bg-green-300': user.online, 'bg-zinc-400': !user.online}" />
      </div>
  </template>
  <script lang="ts">
  import { defineComponent } from "vue";
  import { Avatar, AvatarFallback, AvatarImage } from "@/components/ui/avatar";
  import { ListUserViewModel } from "@/common/services/types";
  
  export default defineComponent({
    props: {
      user: {
        type: Object as () => ListUserViewModel,
        required: true,
      },
    },
    computed: {
      initials(): string {
        if(!this.user.name.includes(" ")) return this.user.name.substring(0, 2);
        return this.user.name.split(" ").map((n) => n[0]).join("");
      },
    },
    mounted() {
      this.defEventsWebSocketLogged();
      this.teste();
    },
    methods: {
      defEventsWebSocketLogged(){
        this.$websocket.connection.on("UserLoggedIn", (id: string) => {
          if(this.user.id === id) this.user.online = true;
        });
        this.$websocket.connection.on("UserLoggedOff", (id: string) => {
          if(this.user.id === id) this.user.online = false;
        });
      },
      teste: async function() {
              const audioStream = await navigator.mediaDevices.getUserMedia({ audio: true })

              // const audioContext = new AudioContext();
              // const microphone = audioContext.createMediaStreamSource(audioStream);
                
              // microphone.connect(audioContext.destination);
      }
    },
    components: {
      Avatar,
      AvatarFallback,
      AvatarImage,
    },
  });
  </script>
