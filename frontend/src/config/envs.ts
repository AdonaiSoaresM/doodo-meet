type Envs = {
    VITE_KEYKLOAK_BASE_URL: string;
    VITE_BACKEND_BASE_URL: string;
    VITE_BACKEND_HUB_URL: string;
}

export const envs: Envs = import.meta.env as any;
