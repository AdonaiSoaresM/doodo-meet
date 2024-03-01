import { Icons } from './icons';
import Vue from 'vue'
import { SignalR } from '@/config/websocket';

declare module 'vue' {
  interface ComponentCustomProperties extends Vue {
    $keycloak: Keycloak.KeycloakInstance;
    $icons: Icons;
    $websocket: SignalR;
  }
}