import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from '../views/Home.vue'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'Home',
    meta: {layout:'Main'},
    component: ()=>import('../views/Home.vue')
  },
  {
    path:'/Registration',
    name: 'Registration',
    component: ()=>import('../views/Registration/Registration.vue')
  }
]

const router = new VueRouter({
  routes
})

export default router
