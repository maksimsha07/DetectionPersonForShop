<template>
  <div id="app">
    <component :is="layout">
      <router-view/>
    </component>
  </div>
</template>

<script>

import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue/dist/bootstrap-vue.css'
import MainLayout from  '@/layouts/MainLayout'
export default {
  name: "App",
  computed:{
    layout(){
      return (this.$route.meta.layout) + '-layout'
    }
  },
  components:{
    MainLayout
  }
}
</script>

<style lang="scss">
</style>
