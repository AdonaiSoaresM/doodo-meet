<template>
  <div>Login</div>
</template>
<script lang="ts">
import { defineComponent } from "vue";

export default defineComponent({
  mounted: function() {
    if(!this.$keycloak?.authenticated) this.$keycloak?.login();
  },
});
</script>
