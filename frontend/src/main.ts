import { createApp } from "vue";
import App from "./App.vue";
import router from "./router";
import keycloak from "./plugins/keycloak";
import "@/assets/index.css";
import icons from "./plugins/icons";
const app = createApp(App);

app.use(router);
app.use(keycloak);
app.use(icons);

app.config.globalProperties.$keycloak
  .init({ onLoad: "login-required" })
  .then(() => {
    app.mount("#app");
  });
