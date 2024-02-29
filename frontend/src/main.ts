import { createApp } from "vue";
import App from "./App.vue";
import router from "./router";
import keycloak from "./plugins/keycloak";
const app = createApp(App);

app.use(router);
app.use(keycloak);

app.config.globalProperties.$keycloak.init({}).then(() => {
  app.mount("#app");
});
