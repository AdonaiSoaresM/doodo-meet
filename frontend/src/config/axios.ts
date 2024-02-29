import axios from "axios";
import { envs } from "./envs";

export const axios_instance = axios.create({
    baseURL: envs.VITE_BACKEND_BASE_URL
  });


export function setToken(AUTH_TOKEN: string) {
    axios_instance.defaults.headers.common['Authorization'] = `Bearer ${AUTH_TOKEN}`;
}


