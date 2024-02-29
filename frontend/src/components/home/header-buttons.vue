<template>
  <div class="flex gap-5">
    <TooltipProvider :delay-duration="100">
      <Tooltip>
        <TooltipTrigger>
          <svgVue color="white" :svg="$icons.mdiAccountMultiplePlus" />
        </TooltipTrigger>
        <TooltipContent>
          <p>Encontrar Amigo</p>
        </TooltipContent>
      </Tooltip>
    </TooltipProvider>
    <TooltipProvider>
      <Tooltip>
        <TooltipTrigger>
          <svgVue color="white" :svg="$icons.mdiMessagePlus" />
        </TooltipTrigger>
        <TooltipContent>
          <p>Nova Chamada</p>
        </TooltipContent>
      </Tooltip>
    </TooltipProvider>
  </div>
</template>
<script lang="ts">
import { defineComponent } from "vue";
import {
  Tooltip,
  TooltipContent,
  TooltipProvider,
  TooltipTrigger,
} from "@/components/ui/tooltip";

export default defineComponent({
  components: {
    Tooltip,
    TooltipContent,
    TooltipProvider,
    TooltipTrigger,
  },
});
</script>
