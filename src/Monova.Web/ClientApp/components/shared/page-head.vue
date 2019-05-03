<template>
    <h4 class="font-font-weight-bold py-4 mb-4">
    <icon v-if="icon" :icon="icon" />    <span class="text-muted font-weight-light">{{ prefix }} /</span> {{ title }}
    </h4>
</template>

<script>
export default {
    props:{
        prefix: {
            default: 'Monova',
            type: String
        },
       title: {
            default: '',
            type: String
        },
        icon: {
            default: '',
            type: String
        }
    }
}
</script>