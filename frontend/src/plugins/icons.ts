import { mdiAccountMultiplePlus, mdiMessagePlus, mdiExitToApp } from "@mdi/js";
import { App } from "vue";

const icons = {
  mdiAccountMultiplePlus,
  mdiMessagePlus,
  mdiExitToApp,
};

export type Icons = typeof icons;

export default {
  install: async (app: App) => {
    app.config.globalProperties.$icons = icons;
  },
};
