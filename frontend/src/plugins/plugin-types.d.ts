import { Icons } from './icons';
import Vue from 'vue'

declare module 'vue' {
  interface ComponentCustomProperties extends Vue {
    $keycloak: Keycloak.KeycloakInstance;
    $icons: Icons;
  }
}