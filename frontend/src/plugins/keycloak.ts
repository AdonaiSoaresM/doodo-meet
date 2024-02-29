import Keycloak from "keycloak-js";
import { App } from "vue";
import { envs } from "@/config/envs";

export default {
  install: async (app: App) => {
    app.config.globalProperties.$keycloak = new Keycloak({
      url: envs.VITE_KEYKLOAK_BASE_URL,
      realm: "myrealm",
      clientId: "myclient",
    });
  },
};
