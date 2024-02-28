
import { createRouter, createWebHistory } from "vue-router";
import routes from "./routes";
import { RouterOptions } from "vue-router";

const options: RouterOptions = {
    history: createWebHistory(),
    routes,
};

const router = createRouter(options);

export default router;