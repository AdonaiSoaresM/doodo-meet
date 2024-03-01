import { SignalR } from "@/config/websocket";
import { App } from "vue";

export default {
  install: async (app: App) => {
    app.config.globalProperties.$websocket = new SignalR();
  },
};
