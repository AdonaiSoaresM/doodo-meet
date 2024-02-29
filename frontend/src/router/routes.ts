import HomeVue from "@/views/Home.vue";
import { RouteRecordRaw } from "vue-router";

const routes: RouteRecordRaw[] = [
  { path: "/", name: "Home", component: HomeVue },
  {
    path: '/:catchAll(.*)',
    redirect: { name: "Home" },
  },
];

export default routes;
