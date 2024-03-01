import { createApp } from "vue";
import App from "./App.vue";
import router from "./router";
import keycloak from "./plugins/keycloak";
import "@/assets/index.css";
import icons from "./plugins/icons";
import svgVue from "./components/ui/svg.vue";
import { setToken } from "./config/axios";
import websocket from "./plugins/websocket";

const app = createApp(App);

app.use(router);
app.use(keycloak);
app.use(websocket);
app.use(icons);
app.component('svgVue', svgVue);

const { $keycloak } = app.config.globalProperties;
const { $websocket } = app.config.globalProperties;

$keycloak
  .init({ onLoad: "login-required" })
  .then(() => {
    setToken($keycloak.token!);
    $websocket.set_token($keycloak.token!);
    $websocket.configure();
    
    app.mount("#app");
  });
